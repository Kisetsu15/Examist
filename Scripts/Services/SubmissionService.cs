using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examist {
    public static class SubmissionService {
        private static readonly HttpClient client = new HttpClient {
            Timeout = TimeSpan.FromSeconds(5)
        };

        public static async Task<IReadOnlyList<SubmissionRecord>> SubmitAndGetLeaderboardAsync(SubmissionRequest request) {
            if (request == null) {
                throw new ArgumentNullException(nameof(request));
            }

            string endpoint = BuildEndpoint("api/submissions");
            string body = JsonConvert.SerializeObject(request);
            using (var content = new StringContent(body, Encoding.UTF8, "application/json")) {
                using (HttpResponseMessage response = await client.PostAsync(endpoint, content).ConfigureAwait(false)) {
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<List<SubmissionRecord>>(json) ?? new List<SubmissionRecord>();
                }
            }
        }

        public static async Task<IReadOnlyList<SubmissionRecord>> GetLeaderboardAsync() {
            string endpoint = BuildEndpoint("api/submissions");
            using (HttpResponseMessage response = await client.GetAsync(endpoint).ConfigureAwait(false)) {
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<List<SubmissionRecord>>(json) ?? new List<SubmissionRecord>();
            }
        }

        private static string BuildEndpoint(string relativePath) {
            string baseUrl = Config.Current.Server?.BaseUrl;
            if (string.IsNullOrWhiteSpace(baseUrl)) {
                throw new InvalidOperationException("Server base URL is not configured in .emt\\config.json.");
            }

            return new Uri(new Uri(AppendTrailingSlash(baseUrl)), relativePath).ToString();
        }

        private static string AppendTrailingSlash(string baseUrl) {
            return baseUrl.EndsWith("/", StringComparison.Ordinal) ? baseUrl : baseUrl + "/";
        }
    }
}

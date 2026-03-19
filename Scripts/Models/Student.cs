namespace Examist {
    public readonly struct Student {
        public string BatchNumber { get; }
        public string Name { get; }

        public Student(string batchNumber, string name) {
            BatchNumber = batchNumber;
            Name = name;
        }
    }
}
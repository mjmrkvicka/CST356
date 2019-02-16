namespace Models {
    public class Person {

        public Person(string f, string m, string l)
        {
            this.first = f;
            this.middle = m;
            this.last = l;
        }
        public string first {get; set; }
        public string middle {get; set; }
        public string last {get; set; }
    }    
}
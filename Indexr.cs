using System;

using Program{
    class IndexerClass{
        private String[] names =new String[10];
        public String this[int i]
        {
            get{
                return names[i];
            }
            set{
                names[i]=value;
            }

        }

        static void Main(String[] args){
            IndexerClass Team =new IndexerClass();
            Team[0] = "Arun";
            Team[1] = "John";
            Team[2] = "Alice";
            Team[3] = "Bob";
            Team[4] = "Charlie";
            Team[5] = "David";
            Team[6] = "Eve";
            Team[7] = "Frank";
            Team[8] = "Grace";
            Team[9] = "Hannah";


            for(int i=0;i<10;i++){
                Console.WriteLine(Team[i]);
            }
        }
    }
}
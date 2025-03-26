namespace widgets{
    public class widgets{}

}

namespace widgets{
    public class widgets{}
}


using widgets;

class Test{
    static void Main(){
        widget w=new widget();
    }
}

// The above code will not compile because the namespace widgets is defined twice.
// The compiler will not be able to distinguish between the two namespaces.




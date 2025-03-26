using static System.Console;    

class Program{
    public static void Main(){

        int i,j,k;

        int[][] a = new int[3][];
        int[][] b = new int[3][];
        int[][] c = new int[3][];
        for (i = 0; i < 3; i++) {
            a[i] = new int[3];
            b[i] = new int[3];
            c[i] = new int[3];
        }

        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Write("Enter the element of a["+i+"]["+j+"]");
        for (i = 0; i < 3; i++) {
            for (j = 0; j < 3; j++) {
                Write("Enter the element of b[" + i + "][" + j + "]");
                b[i][j] = int.Parse(ReadLine());
            }
        }

        for (i = 0; i < 3; i++) {
            for (j = 0; j < 3; j++) {
                c[i][j] = 0;
                for (k = 0; k < 3; k++) {
                    c[i][j] += a[i][k] * b[k][j];
                }
            }
        }
                for(k=0;k<3;k++){
                    c[i][j]+=a[i][k]*b[k][j];
                }
            }
        }

        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Write(c[i][j]+" ");
            }
            WriteLine();
        }


    }
}
public class Calculos{
    private double d1;
    private double d2;
    private double id1;
    private double id2;
    public Calculos(){}
    public void sumayresta(){
        System.Console.WriteLine("Ingrese la incerteza del dato1");
        double id1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese la incerteza del dato2");
        double id2=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine(Convert.ToString(Math.Round((id1+id2),5))+" ± "+Convert.ToString(Math.Round((Math.Pow(id1,2)+Math.Pow(id2,2)),5)));
    }
    public void multiplicacion(){
        System.Console.WriteLine("Ingrese el dato1");
        double d1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese el dato2");
        double d2=Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Ingrese la incerteza del dato1");
        double id1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese la incerteza del dato2");
        double id2=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine(Convert.ToString(Math.Round((d1*d2),5))+" ± "+Convert.ToString(Math.Round(((d1*d2)*Math.Sqrt(Math.Pow((id1/d1),2)+Math.Pow((id2/d2),2))),5)));       
        
    }
    public void division(){
        System.Console.WriteLine("Ingrese el dato1");
        this.d1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese el dato2");
        this.d2=Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Ingrese la incerteza del dato1");
        this.id1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese la incerteza del dato2");
        this.id2=Convert.ToDouble(Console.ReadLine());
        
        System.Console.WriteLine(Convert.ToString(Math.Round((d1/d2),5))+" ± "+Convert.ToString(Math.Round(((d1/d2)*Math.Sqrt(Math.Pow((id1/d1),2)+Math.Pow((id2/d2),2))),5)));
    }
    public void desvest(){
        string separados="";
        System.Console.WriteLine("Ingrese los valores a promediar separados por comas");
        separados=Console.ReadLine();
        int n=separados.Split(',').Length;
        double sumaprom=0;
        double incer=0;
        for(int i=0; i<n;i++){
            sumaprom+=Convert.ToDouble(separados.Split(',')[i]);
        }
        sumaprom/=n;
        for(int i=0;i<n;i++){
            incer+=Math.Pow((Convert.ToDouble(separados.Split(',')[i])-sumaprom),2);
        }
        incer/=n*(n-1);

        System.Console.WriteLine(Convert.ToString(sumaprom)+"±"+Convert.ToString(Math.Sqrt(incer)));
    }
     
}
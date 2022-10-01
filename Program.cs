using System;

Magazine M = new Magazine();
M.Create();
//M.Print();
Magazine M2 = new Magazine();
M2.Create();
//M2.Print();

if(M==M2)
{
    Console.WriteLine("Кол-во сотрудникоу");
    Console.WriteLine(M.kol + " = " + M2.kol);
    //M += M2;
    Console.WriteLine("Прибавляем к "+ M.kol);
    M.chi();
    Console.WriteLine("Прибавить сотрудников " + M.kol + " + " + M.p + " = " + (M.kol += M.p)) ;
}
else
{
    Console.WriteLine("Кол-во сотрудникоу");
    Console.WriteLine(M.kol+ " != " + M2.kol);
    //M -= M2;
    Console.WriteLine("Отнимаем от "+ M2.kol);
    M2.chi();
    Console.WriteLine("Отнять сотрудникоу " + M2.kol + " - " + M2.p + " = " + (M2.kol -= M2.p));
}
if(M>M2)
{
    Console.WriteLine("Кол-во сотрудникоу 1 журнала " + M.kol + " > " + M2.kol+ " второго");
}
else if(M2>M)
{
    Console.WriteLine("Кол-во сотрудникоу 2 журнала " + M2.kol + " > " + M.kol + " первого");
}
else
{
    Console.WriteLine(M.kol + " = " + M2.kol);
}
if (M < M2)
{
    Console.WriteLine("Кол-во сотрудникоу 1 журнала " + M.kol + " < " + M2.kol + " второго");
}
else if(M2<M)
{
    Console.WriteLine("Кол-во сотрудникоу 2 журнала " + M2.kol + " < " + M.kol + " первого");
}
else
{
    Console.WriteLine(M.kol + " = " + M2.kol);
}


Shop S = new Shop();
S.Create();
Shop S2 = new Shop();
S2.Create();
//S.Print();
if (S== S2)
{
    Console.WriteLine("Площадь");
    Console.WriteLine(S.kol + " = " + S2.kol);
    //M += M2;
    Console.WriteLine("Прибавляем.");
    S.chi();
    Console.WriteLine("Прибавить площадь " + S.kol + " + " + S.p + " = " + (S.kol += S.p));
}
else
{
    Console.WriteLine("Площадь");
    Console.WriteLine(S.kol + " != " + S2.kol);
    //M -= M2;
    Console.WriteLine("Отнимаем.");
    S2.chi();
    Console.WriteLine("Отнять площадь " + S2.kol + " - " + S2.p + " = " + (S2.kol -= S2.p));
}
if (S > S2)
{
    Console.WriteLine("Площадь 1 магазина " + S.kol + " > " + S2.kol + " второго");
}
else if (S2 > S)
{
    Console.WriteLine("Площадь 2 магазина " + S2.kol + " > " + S.kol + " первого");
}
else
{
    Console.WriteLine(S.kol + " = " + S2.kol);
}
if (S < S2)
{
    Console.WriteLine("Площадь 1 магазина " + S.kol + " < " + S2.kol + " второго");
}
else if (S2 < S)
{
    Console.WriteLine("Площадь 2 магазина " + S2.kol + " < " + S.kol + " первого");
}
else
{
    Console.WriteLine(S.kol + " = " + S2.kol);
}
class Magazine
{
    public string nameM;
    public string dateM;
    public string opisM;
    public string EmailM;
    public int kol;
    public int p;
    public Magazine() { }

    public string Name
    {
        get { return nameM; }
        set { nameM = value; }
    }
    public string Date
    {
        get { return dateM; }
        set { dateM = value; }
    }
    public string Opis
    {
        get { return opisM; }
        set { opisM = value; }
    }
    public string Email
    {
        get { return EmailM; }
        set { EmailM = value; }
    }
    public int KOL
    {
        get { return kol; }
        set { kol = value; }
    }
    public void Create()
    {
        //Console.WriteLine("Введите название журнала");
        //nameM = Console.ReadLine();
        //Console.WriteLine("Введите дату основания");
        //dateM = Console.ReadLine();
        //Console.WriteLine("Введите описание журнала");
        //opisM = Console.ReadLine();
        //Console.WriteLine("Введите Емейл");
        //EmailM = Console.ReadLine();
        Console.WriteLine("Введите кол-во сотрудникоу");
        kol = Convert.ToInt32(Console.ReadLine());

    }
    public void chi()
    {
        Console.WriteLine("Введите кол-во сотрудников для операции");
        
        p = Convert.ToInt32(Console.ReadLine());
    }
    public static Magazine operator +(Magazine obj1, Magazine obj2)
    {
        Magazine arr = new Magazine();
       
        arr.kol = obj1.kol + obj2.p;
        //arr.kol = obj1.kol;
        return arr;
    }
    public static Magazine operator -(Magazine obj1, Magazine obj2)
    {
        Magazine arr = new Magazine();
        arr.kol = obj1.kol - obj2.p;
        return arr;
    }


    public static bool operator ==(Magazine obj1, Magazine obj2)
    {
        if ((obj1.kol == obj2.kol))
            return true;
        return false;
    }
    public static bool operator !=(Magazine obj1, Magazine obj2)
    {
        if ((obj1.kol == obj2.kol))
            return false;
        return true;
    }

    public static bool operator >(Magazine obj1, Magazine obj2)
    {
        if (obj1.kol > obj2.kol)
            return true;
        return false;
    }
    public static bool operator <(Magazine obj1, Magazine obj2)
    {
        if (obj1.kol < obj2.kol)
            return true;
        return false;
    }

    public void Print()
    {
        Console.WriteLine(nameM);
        Console.WriteLine(dateM);
        Console.WriteLine(opisM);
        Console.WriteLine(EmailM);
    }
}

class Shop
{
    public string nameM;
    public string adres;
    public string opisP;
    public string EmailS;
    public int kol;
    public int p;
    public Shop() { }

    public string Name
    {
        get { return nameM; }
        set { nameM = value; }
    }
    public string Path
    {
        get { return adres; }
        set { adres = value; }
    }
    public string Opis
    {
        get { return opisP; }
        set { opisP = value; }
    }
    public string IP
    {
        get { return EmailS; }
        set { EmailS = value; }
    }
    public void Create()
    {
        //Console.WriteLine("Введите название магазина");
        //nameM = Console.ReadLine();
        //Console.WriteLine("Введите адрес");
        //adres = Console.ReadLine();
        //Console.WriteLine("Введите описание магазина");
        //opisP = Console.ReadLine();
        //Console.WriteLine("Введите емейл");
        //EmailS = Console.ReadLine();
        Console.WriteLine("Введите площадь");
        kol = Convert.ToInt32(Console.ReadLine());

    }
    public void chi()
    {
        Console.WriteLine("Введите площадь для операции");

        p = Convert.ToInt32(Console.ReadLine());
    }
    public static Shop operator +(Shop obj1, Shop obj2)
    {
        Shop arr = new Shop();

        arr.kol = obj1.kol + obj2.p;
        //arr.kol = obj1.kol;
        return arr;
    }
    public static Shop operator -(Shop obj1, Shop obj2)
    {
        Shop arr = new Shop();
        arr.kol = obj1.kol - obj2.p;
        return arr;
    }


    public static bool operator ==(Shop obj1, Shop obj2)
    {
        if ((obj1.kol == obj2.kol))
            return true;
        return false;
    }
    public static bool operator !=(Shop obj1, Shop obj2)
    {
        if ((obj1.kol == obj2.kol))
            return false;
        return true;
    }

    public static bool operator >(Shop obj1, Shop obj2)
    {
        if (obj1.kol > obj2.kol)
            return true;
        return false;
    }
    public static bool operator <(Shop obj1, Shop obj2)
    {
        if (obj1.kol < obj2.kol)
            return true;
        return false;
    }

    public void Print()
    {
        Console.WriteLine(nameM);
        Console.WriteLine(adres);
        Console.WriteLine(opisP);
        Console.WriteLine(EmailS);
    }
}

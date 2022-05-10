

using dioPOO.Entities;

Hero Arus= new Hero("Arus",6,"Knight"); 
Hero Fenicce= new Wizard("Fenicce",9,"White Wizard"); 



Console.WriteLine(Fenicce.ToString());
Console.WriteLine(Arus.ToString());
Console.WriteLine(Fenicce.Attack(7));
Console.WriteLine(Arus.Attack());

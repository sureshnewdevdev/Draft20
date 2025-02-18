// See https://aka.ms/new-console-template for more information
using ProductCatch;
using ProductCatch.Interfaces;

Console.WriteLine("Hello, World!");

DiscountProduct product = new DiscountProduct();
product.ProductId = 1;
product.ProductName = "Laptop";
product.Price = 1000;

product.Discount = 100;
Console.WriteLine(product.GetProductInfo());
Console.WriteLine($"Discount Price: {product.GetDiscountPrice()}");

Man man = new Man {
    Id=2,
    Name = "John",
    FreeTravelBy= "Walk or Run"
};

Woman woman = new Woman {
    Id = 1,
    Name = "Jane",
    FreeTravelByBus = "Bus"
};



string  GetPersonDetails(Person person)
{

    if (person is Man)
    {
        man = person as Man;
        Console.Write("MR. ");
    }
    else if (person is Woman)
    {
        woman = person as Woman;
        Console.Write("MRS. ");
    }
    
    return person.Name + "    " + person.Id;
}


var result= GetPersonDetails(woman);
Console.WriteLine(result);

 result= GetPersonDetails(man);
Console.WriteLine(result);



CMRTime cMRTime = new CMRTime();

IA ia = cMRTime;
ia.GetDateTime();

IB ib = cMRTime;
ib.GetDateTime();
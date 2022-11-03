using Builder;

var builder = new InvoiceBuilder();


//builder.SetDate(new DateTime(2022, 1, 1));
//builder.SetInvoiceNumber(1);
//builder.SetVendor("Google");
//builder.SetVendee("Vendee");
//builder.SetLineItems(new List<string> { "Item1", "Item2" });

//Invoice invoice = builder.Build();

Invoice invoice = builder.SetDate(new DateTime(2022, 1, 1))
       .SetInvoiceNumber(1)
       .SetVendor("Google")
       .SetVendee("Vendee")
       .SetLineItems(new List<string> { "Item1", "Item2" })
       .Build();


Console.WriteLine("Vendor: {0}\nVendee: {1}", invoice.Vendor, invoice.Vendee);






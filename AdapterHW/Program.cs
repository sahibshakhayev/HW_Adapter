Laptop my_laptop = new Laptop();
DCPowerSuply powerSuply = new DCPowerSuply();
my_laptop.Charge_Battery(powerSuply);

EuroSocket socket = new EuroSocket();
I_DC_19V laptop_adapter = new LaptopAdapter(socket);
my_laptop.Charge_Battery(laptop_adapter);

        
        
 Console.Read();

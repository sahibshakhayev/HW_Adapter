Laptop my_laptop = new Laptop();
DCPowerSuply powerSuply = new DCPowerSuply();

my_laptop.Charge_Battery(powerSuply);

EuroSocket socket = new EuroSocket();
LaptopAdapter laptop_adapter = new LaptopAdapter();
laptop_adapter.AC_220V = socket;

my_laptop.Charge_Battery(laptop_adapter);

        
        
 Console.Read();

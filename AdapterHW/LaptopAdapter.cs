



class LaptopAdapter : I_DC_19V
{
    I_AC_220V AC_220V;
    public LaptopAdapter(I_AC_220V source)
    {
       AC_220V = source;
    }

    public void Give_DC_19V()
    {
        AC_220V.Give_AC_220V();
    }
}
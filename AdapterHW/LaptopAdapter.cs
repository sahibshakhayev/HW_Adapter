



class LaptopAdapter : I_DC_19V
{
    private I_AC_220V _ac_220V;
    public I_AC_220V? AC_220V { set => _ac_220V = value; }


  

    public void Give_DC_19V()
    {
        if (_ac_220V != null)
        {
            _ac_220V.Give_AC_220V();
        }
    }
}
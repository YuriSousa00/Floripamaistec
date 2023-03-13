namespace TratExcRegraDeNegocio
{
    public class IngressoException : Exception
    {
        public IngressoException()
        {
        }
        
        public IngressoException(String msg) : base(msg)
        {
        }

        public IngressoException(String msg, Exception causa) : base(msg, causa)
        {
        }

    }
}
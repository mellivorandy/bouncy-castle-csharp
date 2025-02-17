namespace BouncyCastleCSharp.RSA
{
    internal interface IRSA
    {
        byte[] Encrypt();
        byte[] Decrypt();
    }
}

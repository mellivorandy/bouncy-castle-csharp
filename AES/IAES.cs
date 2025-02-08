namespace BouncyCastleCSharp.AES
{
    internal interface IAES
    {
        byte[] Encrypt(byte[] plainText, byte[] key, byte[] iv);
        byte[] Decrypt(byte[] cipherText, byte[] key, byte[] iv);
    }
}

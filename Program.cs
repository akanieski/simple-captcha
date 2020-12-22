using System;

namespace captcha_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = Captcha.GenerateCaptchaCode();
            Console.WriteLine($"Code: {code}");
            var result = Captcha.GenerateCaptchaImage(300,100, code);
            System.IO.File.WriteAllBytes($"{result.CaptchaCode}.png", result.CaptchaByteData);

        }
    }
}

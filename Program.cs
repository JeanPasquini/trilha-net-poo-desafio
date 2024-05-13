using DesafioPOO.Models;

            Nokia nokia = new Nokia("123456789", "Nokia XYZ", "IMEI123", 64);
            Console.WriteLine("Informações do Nokia:");
            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria}GB");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            
            Console.WriteLine();

            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
            Console.WriteLine("Informações do iPhone:");
            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria}GB");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
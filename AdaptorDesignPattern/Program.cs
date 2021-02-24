using System;

namespace AdaptorDesignPattern
{

    class VgaStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;
        }
    }

    class DviStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;
        }
    }
    class VgaGraphicCard
    {
        public VgaStream GetVgaStream()
        {
            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }

    class DviMonitor
    {
        private byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        } 
    }

    class VgaGraphicCardAdaptor
    {
        private VgaGraphicCard _vgaGraphicCard;

        public VgaGraphicCardAdaptor(VgaGraphicCard vgaGraphicCard)
        {
                _vgaGraphicCard=vgaGraphicCard;
        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicCard.GetVgaStream().GetData();

            byte[] CovertData = ConvertVgaToDvi(data);
            DviStream dviStream = new DviStream();
            dviStream.SetData(CovertData);
            return dviStream;
        }

        public byte[] ConvertVgaToDvi(byte[] input)
        {
            Console.WriteLine("Coverted video from Vga to DVI");
            return new byte[] { };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting Input For DVI ");
            VgaGraphicCard vgaGraphicCard = new VgaGraphicCard();
            DviMonitor dviMonitor = new DviMonitor();
            VgaGraphicCardAdaptor vgaGraphicCardAdaptor = new VgaGraphicCardAdaptor(vgaGraphicCard);
            dviMonitor.SetInput(vgaGraphicCardAdaptor.GetDviStream());
           
        }
    }
}

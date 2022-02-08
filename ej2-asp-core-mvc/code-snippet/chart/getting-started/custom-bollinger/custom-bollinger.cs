public ActionResult Index()
    {
        List<Data> chartData = new List<Data>
        {
            new Data { x= new DateTime(2012,04,02), open= 85.9757, high= 90.6657, low= 85.7685, close= 90.5257, volume= 660187068 },
            new Data { x= new DateTime(2012,04,09), open= 89.4471, h igh= 92, low= 86.2157, close= 86.4614, volume= 912634864 },
            new Data { x= new DateTime(2012,04,16), open= 87.1514, high= 88.6071, low= 81.4885, close= 81.8543, volume= 1221746066 },
            new Data { x= new DateTime(2012,04,23), open= 81.5157, high= 88.2857, low= 79.2857, close= 86.1428, volume= 965935749 },
            new Data { x= new DateTime(2012,04,30), open= 85.4, high= 85.4857, low= 80.7385, close= 80.75, volume= 615249365 },
            new Data { x= new DateTime(2012,05,07), open= 80.2143, high= 82.2685, low= 79.8185, close= 80.9585, volume= 541742692 },
            new Data { x= new DateTime(2012,05,14), open= 80.3671, high= 81.0728, low= 74.5971, close= 75.7685, volume= 708126233 },
            new Data { x= new DateTime(2012,05,21), open= 76.3571, high= 82.3571, low= 76.2928, close= 80.3271, volume= 682076215 },
            new Data { x= new DateTime(2012,05,28), open= 81.5571, high= 83.0714, low= 80.0743, close= 80.1414, volume= 480059584 },
            new Data { x= new DateTime(2012,06,04), open= 80.2143, high= 82.9405, low= 78.3571, close= 82.9028, volume= 517577005 },
            new Data { x= new DateTime(2012,06,11), open= 83.96, high= 84.0714, low= 80.9571, close= 82.0185, volume= 499693120 },
            new Data { x= new DateTime(2012,06,18), open= 81.5657, high= 84.2857, low= 81.4814, close= 83.1571, volume= 442172142 },
            new Data { x= new DateTime(2012,06,25), open= 82.4714, high= 83.4285, low= 80.8014, close= 83.4285, volume= 371529102 },
            new Data { x= new DateTime(2012,07,02), open= 83.5328, high= 87.7628, low= 83.3714, close= 86.5543, volume= 385906790 },
            new Data { x= new DateTime(2012,07,09), open= 86.4714, high= 88.5528, low= 84.6685, close= 86.4243, volume= 524235196 },
            new Data { x= new DateTime(2012,07,16), open= 86.4457, high= 87.9071, low= 86.1643, close= 86.3285, volume= 419537217 },
            new Data { x= new DateTime(2012,07,23), open= 84.9143, high= 87.0971, low= 81.4285, close= 83.5943, volume= 680773023 },
            new Data { x= new DateTime(2012,07,30), open= 84.4171, high= 88.2828, low= 83.9743, close= 87.9571, volume= 475109323 },
            new Data { x= new DateTime(2012,08,06), open= 88.1843, high= 89.2857, low= 87.8943, close= 88.8143, volume= 312826308 },
            new Data { x= new DateTime(2012,08,13), open= 89.0557, high= 92.5985, low= 89.0357, close= 92.5871, volume= 392867193 },
            new Data { x= new DateTime(2012,08,20), open= 92.8585, high= 96.4114, low= 92.5871, close= 94.746, volume= 708614692 },
            new Data { x= new DateTime(2012,08,27), open= 97.1414, high= 97.2671, low= 93.8928, close= 95.0343, volume= 383807217 },
            new Data { x= new DateTime(2012,09,03), open= 95.1085, high= 97.4971, low= 94.9285, close= 97.2057, volume= 355722047 },
            new Data { x= new DateTime(2012,09,10), open= 97.2071, high= 99.5685, low= 93.7143, close= 98.7543, volume= 724042207 },
            new Data { x= new DateTime(2012,09,17),  open= 99.9071, high= 100.7243, low= 99.0885, close= 100.0135, volume= 500166040 },
            new Data { x= new DateTime(2012,09,24), open= 98.1228, high= 99.3028, low= 94.3357, close= 95.3007, volume= 714507994 },
            new Data { x= new DateTime(2012,10,01), open= 95.88, high= 96.6785, low= 92.95, close= 93.2271, volume= 638543622 },
            new Data { x= new DateTime(2012,10,08), open= 92.4114, high= 92.5085, low= 89.0785, close= 89.9591, volume= 747127724 },
            new Data { x= new DateTime(2012,10,15), open= 90.3357, high= 93.2557, low= 87.0885, close= 87.12, volume= 646996264 },
            new Data { x= new DateTime(2012,10,22),  open= 87.4885, high= 90.7685, low= 84.4285, close= 86.2857, volume= 866040680 },
            new Data { x= new DateTime(2012,10,29), open= 84.9828, high= 86.1428, low= 82.1071, close= 82.4, volume= 367371310 },
            new Data { x= new DateTime(2012,11,05), open= 83.3593, high= 84.3914, low= 76.2457, close= 78.1514, volume= 919719846 },
            new Data { x= new DateTime(2012,11,12), open= 79.1643, high= 79.2143, low= 72.25, close= 75.3825, volume= 894382149 },
            new Data { x= new DateTime(2012,11,19), open= 77.2443, high= 81.7143, low= 77.1257, close= 81.6428, volume= 527416747 },
            new Data { x= new DateTime(2012,11,26), open= 82.2714,  high= 84.8928, low= 81.7514, close= 83.6114, volume= 646467974 },
            new Data { x= new DateTime(2012,12,03), open= 84.8071, high= 84.9414,  low= 74.09, close= 76.1785, volume= 980096264 },
            new Data { x= new DateTime(2012,12,10), open= 75,  high= 78.5085, low= 72.2257, close= 72.8277, volume= 835016110 },
            new Data { x= new DateTime(2012,12,17), open= 72.7043, high= 76.4143, low= 71.6043, close= 74.19, volume= 726150329 },
            new Data { x= new DateTime(2012,12,24), open= 74.3357, high= 74.8928, low= 72.0943, close= 72.7984,  volume= 321104733 },
            new Data { x= new DateTime(2012,12,31), open= 72.9328, high= 79.2857, low= 72.7143,  close= 75.2857, volume= 540854882 },
            new Data { x= new DateTime(2013,01,07), open= 74.5714, high= 75.9843, low= 73.6, close= 74.3285, volume= 574594262 },
            new Data { x= new DateTime(2013,01,14), open= 71.8114, high= 72.9643, low= 69.0543, close= 71.4285, volume= 803105621 },
            new Data { x= new DateTime(2013,01,21), open= 72.08, high= 73.57, low= 62.1428, close= 62.84, volume= 971912560 },
            new Data { x= new DateTime(2013,01,28), open= 62.5464, high= 66.0857, low= 62.2657, close= 64.8028, volume= 656549587 },
            new Data { x= new DateTime(2013,02,04), open= 64.8443, high= 68.4014, low= 63.1428, close= 67.8543, volume= 743778993 },
        };  
        ViewBag.dataSource = chartData;
        return View();
    }
    public class Data
    {
        public DateTime x;
        public double open;
        public double high;
        public double low;
        public double close;
        public double volume;
    }
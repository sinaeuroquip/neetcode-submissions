 public class TimeMap
 {
     Dictionary<string, List<Data>> map;
     public TimeMap()
     {
         map = new Dictionary<string, List<Data>>();
     }

     public void Set(string key, string value, int timestamp)
     {
         if (!map.ContainsKey(key))
             map.Add(key, new List<Data>());

         map[key].Add(new Data(value, timestamp));

     }

     public string Get(string key, int timestamp)
     {
         if (!map.ContainsKey(key))
             return "";

         List<Data> data = map[key];

         return findClosestValue(data, timestamp);
     }

     private string findClosestValue(List<Data> data, int timestamp)
     {
         var l = 0;
         var r = data.Count - 1;

         while (l <= r)
         {
             var m = l + (r - l) / 2;

             if (data[m].timeStamp <= timestamp)
                 l = m + 1;
             else
                 r = m - 1;
         }
        if(r<0)
             return "";

         Data clossetData = data[r];

         return clossetData.value;
     }


 }
 public class Data
 {
     public string value { get; set; }
     public int timeStamp { get; set; }

     public Data(string value, int timeStamp)
     {
         this.value = value;
         this.timeStamp = timeStamp;
     }
 }
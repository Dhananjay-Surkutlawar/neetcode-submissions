public class MyHashMap {
    List<Map> list;
    public MyHashMap() {
        list = new List<Map>();
    }
    
    public void Put(int key, int value) {
       Map obj = new Map(key,value);
       int index = list.FindIndex(x => x.Key == key);
       if (index != -1)
       {
            list[index].Value = value;
       }
       else
       {
           list.Add(obj);
       }
        
    }
    
    public int Get(int key) {
        int index = list.FindIndex(x => x.Key == key);
        return index == -1 ? -1 : list[index].Value;
    }
    
    public void Remove(int key) {
       int index = list.FindIndex(x => x.Key == key);
       if (index != -1)
       {
            list.RemoveAt(index);
       }

    }

}
public class Map
{
    public int Key;
    public int Value;

    public Map(int key, int value)
    {
        Key = key;
        Value = value;
    }
}
/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
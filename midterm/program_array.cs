//This problem worthy of 7.5%
using System.Collections;

public class MyArrayList
{
    private ArrayList list;

    public MyArrayList()
    {
        list = new ArrayList();
    }

    public void Add(int item)
    {
        // TODO: Complete the Add method to add an item to the ArrayList
        list.Add(item);
    }

    public bool Contains(int item)
    {
        // TODO: Complete the Contains method to check if the ArrayList contains the specified item
        bool result = false;
        foreach (int i in list)
        {
            if (i == item)
            {
                result = true;
                break;
            }
        }
        return result;
    }

    
}


namespace ArrayAdt;

/// <summary>
/// This class implements a simple Array-like ADT for storing
/// integers. After creating an instance, we can get and
/// set values and get the length.  We can also resize the
/// capacity of an instance - it does not automatically grow.
/// </summary>
public class Barray
{
    // You probably want some data member(s) on your class here
    private int[]? intArray = null;

    /// <summary>
    /// Create an instance with the specified capacity.
    /// The initial values of all elements will be zero.
    /// </summary>
    /// <param name="size">The maximum capacity of the array.</param>
    public Barray(uint size)
    {
        intArray = new int[size];
    }

    /// <summary>
    /// Create an instance initialized with the initial values.
    /// The capacity is the same as the number of values.
    /// </summary> 
    /// <param name="values">The initial values to store in the array.</param>
    public Barray(int[] values)
    {
        intArray = values;
    }

    /// <summary>
    /// The length or capacity of the array.
    /// </summary>
    /// <returns>The length/capacity.</returns>
    public uint Length()
    {
        if (intArray == null)
        {
            return 0;
        }

        return (uint)intArray.Length;
    }

    /// <summary>
    /// Get the value at the specified index.
    /// </summary>
    /// <param name="index">The index in the array to fetch.</param>
    /// <returns>The value.</returns>
    public int Get(uint index)
    {

        return intArray[index];
    }

    /// <summary>
    /// Set the value at the specified index.
    /// </summary>
    /// <param name="index">The index in the array to set.</param>
    /// <param name="value">The value to store.</param>
    public void Set(uint index, int value)
    {
        intArray[index] = value;
    }

    /// <summary>
    /// Resize the capacity of the array. It can be higher or
    /// lower than the existing capacity.
    /// </summary>
    /// <param name="newLength">The new capacity of the array.</param>
    public void Resize(uint newLength)
    {
        throw new NotImplementedException();
    }
}

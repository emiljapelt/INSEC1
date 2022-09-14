using static Groups.Groups;
using static Groups.Helpers;

namespace Groups;

public class Group<T>
{
    public T neutralElement { get; internal set; }
    public Func<T, T, T> op { get; internal set; }
    public Func<T, T> inverse { get; internal set; }
}

public static class Helpers
    {
        public static string shortToBitString(ushort s)
        {
            var coll = new string[16];
            for(int i = 15; i > 0; i--)
            {
                coll[i] = (s % 2 == 0) ? "0" : "1";
                s /= 2;
            }
            return string.Join("", coll);
        }
    }

public static class Groups
{
    public static Group<int> IntAdd_G = new Group<int>() { 
        neutralElement = 0, 
        op = (a, b) => a + b, 
        inverse = (a) => -a 
    };

    public static Group<ushort> Bit16Xor_G = new Group<ushort>() { 
        neutralElement = 0, 
        op = (a, b) => (ushort)(a ^ b), 
        inverse = (a) => (ushort)(a)
    };

    public static Group<int> IntMul_G = new Group<int>() {
        neutralElement = 1,
        op = (a, b) => a * b,
        inverse = (a) => -a
    };
}

public class Program
{
    public static void Main(string[] args)
    {
        var random = new Random();
        
        allTests(
            "Integers with addition",
            IntAdd_G,
            () => random.Next(),
            100
        );

        allTests(
            "16bit strings with XOR",
            Bit16Xor_G,
            () => (ushort)random.Next(),
            100
        );

        allTests(
            "Integers with multiplication",
            IntMul_G,
            () => random.Next(),
            100
        );

        Console.WriteLine(exponentiate(IntAdd_G, 2, 4));
    }

    public static T exponentiate<T>(Group<T> group, T start, int runs)
    {
        var result = start;
        for(int i = 0; i < runs; i++) result = group.op(result, start);
        return result;
    }

    public static void allTests<T>(string groupName, Group<T> group, Func<T> generator, int runs)
    {
        Console.WriteLine($"Testing group '{groupName}'...");
        groupIdentityTest(group, generator, runs);
        groupInverseTest(group, generator, runs);
        groupCommutativeTest(group, generator, runs);
        groupAssociativeTest(group, generator, runs);
        Console.WriteLine();
    }

    // The group operation applied to some element 'e' and the group identity, gives 'e'
    public static void groupIdentityTest<T>(Group<T> group, Func<T> generator, int runs)
    {
        while(runs > 0) {
            var element = generator();
            if(!EqualityComparer<T>.Default.Equals(group.op(element, group.neutralElement), element)) {
                Console.WriteLine("*identity testing, failure!");
                return;
            }
            runs--;
        }
        Console.WriteLine("identity testing, success!");
    }

    // The group operation applied to some element 'e' and its inverse, gives the group identity
    public static void groupInverseTest<T>(Group<T> group, Func<T> generator, int runs)
    {
        while(runs > 0) {
            var element = generator();
            if(!EqualityComparer<T>.Default.Equals(group.op(element, group.inverse(element)), group.neutralElement)) {
                Console.WriteLine("*inverse testing, failure!");
                return;
            }
            runs--;
        }
        Console.WriteLine("inverse testing, success!");
    }

    // The operands can be flipped, without impacting the result 
    public static void groupCommutativeTest<T>(Group<T> group, Func<T> generator, int runs)
    {
        while(runs > 0) {
            var element1 = generator();
            var element2 = generator();

            if(!EqualityComparer<T>.Default.Equals(group.op(element1, element2), group.op(element2, element1))){
                Console.WriteLine("*commutative testing, failure!");
                return;
            }
            runs--;
        }
        Console.WriteLine("commutative testing, success!");
    }

    // Changing the order of operation application, does not impact the result
    public static void groupAssociativeTest<T>(Group<T> group, Func<T> generator, int runs)
    {
        while(runs > 0) {
            var element1 = generator();
            var element2 = generator();
            var element3 = generator();

            if(!EqualityComparer<T>.Default.Equals(group.op(group.op(element1, element2), element3), group.op(element1, group.op(element2, element3)))){
                Console.WriteLine("*associative testing, failure!");
                return;
            }
            runs--;
        }
        Console.WriteLine("associative testing, success!");
    }
}
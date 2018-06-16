# ListShuffler

# ABOUT
<h4>No to Random! Yes to Shuffled! Shuffling your List isn't a problem now, thanks to ListShuffler in C#.Net</h4>


## HOW TO USE?
<code>
using ListShuffler;
</code>

<pre>
Collections col = new Collections();
List<int> integers = new List<int>();
integers.Add(1);
integers.Add(2);
integers.Add(3);
integers.Add(4);
integers.Add(5);

foreach(int ix in col.Shuffle&lt;int&gt;(integers)){
  Console.WriteLine(ix);
}
  
Console.ReadKey();
</pre>

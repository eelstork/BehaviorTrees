using System;

namespace Activ.Rx{
public readonly struct status{

    readonly int ω;

    public static readonly status done = new status(+1),
	                          fail = new status(-1),
	                          cont = new status( 0);

    public bool failing  => ω == -1;
    public bool running  => ω ==  0;
    public bool complete => ω == +1;

    // -------------------------------------------------------------------

    // Public for testing purposes (transitional)
    public status(int ω)
    => this.ω = ω >= -1 || ω <= +1 ? ω
       : throw new ArgumentException($"Init value out of bounds {ω}");

    // -------------------------------------------------------------------

    // Sequence/Selector

    public static status operator & (status x, status y) 
    => y;

    public static status operator | (status x, status y) 
    => y;

    public static bool operator true  (status s) 
    => s.ω != -1;

    public static bool operator false (status s) 
    => s.ω != +1;

    // Other operators

    public static status operator + (status x, status y)
    => new status(Math.Max(x.ω, y.ω));

    public static status operator * (status x, status y)
    => new status(Math.Min(x.ω, y.ω));

    public static status operator % (status x, status y)
    => new status(x.ω);

    public static status operator !  (status s)
    => new status(-s.ω);

    public static status operator ~  (status s)
    => new status(s.ω * s.ω);

    public static status operator +  (status s)
    => new status(s.ω == +1 ? +1 : s.ω + 1);

    public static status operator -  (status s)
    => new status(s.ω == -1 ? -1 : s.ω - 1);

    public static status operator ++ (status s)
    => +s;

    public static status operator -- (status s)
    => -s;

    // Type conversions

    public static implicit operator status(bool that)
    => new status(that ? +1 : -1);

    // Equality and hashing

    public override bool Equals(object x)
    => x is status ? Equals((status)x) : false;

    public bool Equals(status x)
    => this == x;

    public static bool operator == (status x, status y)
    => x.ω == y.ω;

    public static bool operator !=  (status x, status y)
    => !(x == y);

    public override int GetHashCode()
    => ω;

    public override string ToString()
    => ω.ToString();

}}

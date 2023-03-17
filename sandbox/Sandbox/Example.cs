public class CarKMCity
{
  private int _cityKM = 7;
  
  private int _totalFuelPerLiter = 50;

  public virtual float KmPerLiter()
  {
    return _cityKM *_totalFuelPerLiter; // total fuel per KM on a road.
  }
}

// a child class
public class CarKMRoad : CarKMCity
{
 private int _roadKM = 14;
  
  private int _totalFuelLitter= 50;

  public override float KmPerLiter()
  {
    return _roadKM  * _totalFuelLitter; // total fuel per KM on a road.
  }
}
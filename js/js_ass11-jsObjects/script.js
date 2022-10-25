class Vehicle{
  constructor(vehicleId,brand,model,varaint){
    this.vehicleId=vehicleId;
    this.brand=brand;
    this.model=model;
    this.variant=varaint;
  }

  specification={
      firstGear:function(){
      console.log("First Gear");
    },
      secondGear:function(){
      console.log("Second Gear");
    },
    maxSpeed:180,
    changeGear:function(){
        this.firstGear();
        this.secondGear();
      }
  }
}

var car = new Vehicle(101,"maruti","alto","dxl");

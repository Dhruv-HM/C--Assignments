class Vehicle{
    constructor(vehicleId,brand,model,variant){
        this.brand=brand;
        this.model=model;
        this.vehicleId=vehicleId;
        this.variant=variant;
    }

    //member functions


}

specification={    firstGear: function(){
    console.log("in the first gear");
},

secondGear: function(){
    console.log("in the second gear");
},

changeGear:function(){
    let maxSpeed=100;
    this.firstGear();
    this.secondGear();
    console.log(maxSpeed);
    }
}
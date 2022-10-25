class Training{
    category:string;
    title:string;
    duration:number;

    constructor(category:string,title:string,duration:number){
        this.category=category;
        this.duration=duration;
        this.title=title;
    }

    display():void{
        console.log(`Category: ${this.category} title: ${this.title} Duration: ${this.duration}`);
    }
}

class CartWithTraingings{
    trainings:Training[]=[]
    constructor(trainings:Training[]){
        this.trainings;
    }

    addTraining(train:Training){
        this.trainings.push(train);
    }
    
    removeTraining(index:number){
        for (let index = 0; index < this.trainings.length; index++) {
            this.trainings.splice(index,1);
            
        }
    }

    display(){
        for (let index = 0; index < this.trainings.length; index++) {
            this.trainings[index].display();
            
        }

    }
}
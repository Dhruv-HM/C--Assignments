import { getDebugNode } from "@angular/core";

export class Contact {
    id:number=0;
    firstName:string="";
    lastName:string="";
    gender:string="";
    dob:string="";
    email?:string;
    phone?:string;
    city?:string;
    state?:string;
    country?:string;
    picture?:string;

    constructor( id:number,firstName:string,lastName:string,gender:string,dob:string,email?:string,phone?:string,city?:string,state?:string,country?:string,picture?:string){
        this.id=id;
        this.firstName=firstName;
        this.lastName=lastName;
        this.gender=gender;
        this.dob=dob;
        this.email=email;
        this.phone=phone;
        this.city=city;
        this.state=state;
        this.country=country;
        this.picture=picture;
    }
    
}


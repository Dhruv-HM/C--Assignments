import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact';


@Component({
  selector: 'contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {
  contacts:Contact[]=[];
  constructor() {
   
   }

  ngOnInit(): void {
    this.contacts.push(new Contact(1,"Chotta","Bheem","Male","09-12-'88","bheem.chotta@gmail.com","123675","Dholakpur","Bihar","India","./assets/images/1.jpg"));
    this.contacts.push(new Contact(2,"Chutki","Chutki","Female","09-12-'88","Chutki@gmail.com","123675","Dholakpur","Bihar","India","./assets/images/2.jpg"));
    this.contacts.push(new Contact(3,"Raju","super","Male","09-13-'88","Chutki@gmail.com","123675","Dholakpur","Bihar","India","./assets/images/3.jpg"));
    this.contacts.push(new Contact(4,"Jaggu","Bandhar","Monkey","03-12-'88","Chutki@gmail.com","123675","Dholakpur","Bihar","India","./assets/images/4.jpg"));
    this.contacts.push(new Contact(5,"Khalia","fat","Male","09-12-'88","Chutki@gmail.com","123675","Dholakpur","Bihar","India","./assets/images/5.jpg"));
  }

  deleteContact(id:number){
    for(let i=0;i<this.contacts.length;i++){
      if(this.contacts[i].id==id){
        this.contacts.splice(i,1);
        break;
      }
    }
  }

}

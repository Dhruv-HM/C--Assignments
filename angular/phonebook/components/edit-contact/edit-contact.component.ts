import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { FormControl } from '@angular/forms';
import { Contact } from 'src/app/models/contact';


@Component({
  selector: 'edit-contact',
  templateUrl: './edit-contact.component.html',
  styleUrls: ['./edit-contact.component.css']
})
export class EditContactComponent implements OnInit {

  editForm?:FormGroup;
  
  constructor() {
    
   }
   
  ngOnInit(): void {
    let contact=new Contact(1,'dolu','bolu','male','12-23-45','dolu@gmail.com','12234567','dholakpur','bihar','India','url');
    this.editForm = new FormGroup(
      {
        id:new FormControl(contact.id),
        firstname:new FormControl(contact.firstName,Validators.required),
        lastname:new FormControl(contact.lastName,Validators.compose([Validators.required,Validators.minLength(5)])),
        gender:new FormControl(contact.gender),
        dob:new FormControl(contact.dob),
        email:new FormControl(contact.email),
        phone:new FormControl(contact.phone),
        city:new FormControl(contact.city),
        state:new FormControl(contact.state),
        country:new FormControl(contact.state),
        picture:new FormControl(contact.picture)
  
      }
    );
  }
  saveContact(contact:Contact){
    console.log(contact);
  }

}

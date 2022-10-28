import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact';

@Component({
  selector: 'add-contact',
  templateUrl: './add-contact.component.html',
  styleUrls: ['./add-contact.component.css']
})
export class AddContactComponent implements OnInit {

  contact:Contact= new Contact(0,"","","","","","","","","","");
  constructor() { }

  ngOnInit(): void {
  }

  addContact(){
    console.log(this.contact);
  }

}

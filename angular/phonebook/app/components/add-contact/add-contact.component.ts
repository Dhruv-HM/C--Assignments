import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/models/contact';
import { ContatcService } from 'src/app/services/contatc-service.service';

@Component({
  selector: 'add-contact',
  templateUrl: './add-contact.component.html',
  styleUrls: ['./add-contact.component.css']
})
export class AddContactComponent implements OnInit {

  contact:Contact= new Contact(0,"","","","","","","","","","");
 
  constructor(private contactService:ContatcService,private router:Router) { }

  ngOnInit(): void {
  }

  addContact(){
    // console.log(this.contact);
    this.contactService.addNewContact(this.contact).subscribe(res=>{this.router.navigate(["/contact-list"]);});
    // this.router.navigate(["/contact-list"]);
  }

}

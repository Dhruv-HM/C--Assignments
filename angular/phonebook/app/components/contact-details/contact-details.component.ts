import { Component, OnInit } from '@angular/core';
import {Contact} from 'src/app/models/contact'
import { ContatcService } from 'src/app/services/contatc-service.service';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.css']
})
export class ContactDetailsComponent implements OnInit {
  contact:Contact=new Contact(1,"","","","","","","","","","");

  constructor(private contactService:ContatcService) { }

  ngOnInit(): void {

      this.contactService.getContactDetails(3).subscribe(data=>this.contact=data);
    // this.contact.id=1;
    // this.contact.firstName="Chotta";
    // this.contact.lastName="Bheem";
    // this.contact.gender="Male";
    // this.contact.dob="09-78-09";
    // this.contact.email="bheem.chotta@gmails.com"
    // this.contact.phone="1233456";
    // this.contact.city="Dholakpur";
    // this.contact.state="Bihar";
    // this.contact.country="India";

  }

}

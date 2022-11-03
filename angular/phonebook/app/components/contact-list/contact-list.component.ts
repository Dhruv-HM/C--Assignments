import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/models/contact';
import { ContatcService } from 'src/app/services/contatc-service.service';


@Component({
  selector: 'contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {
  contacts:Contact[]=[];
  constructor(private contactService:ContatcService,private router:Router) {
   
   }

  ngOnInit(): void {
    this.contactService.getAllContacts().subscribe(data=>{this.contacts=data;});
  }


  // deleteContact(id:number){
    
  //   for(let i=0;i<this.contacts.length;i++){
  //     if(this.contacts[i].id==id && confirm("Are you sure you wanna delete pa?")){
  //       this.contacts.splice(i,1);
  //       break;
  //     }
  //   }
  // }
  
  
    reload(){
      alert("trying to delete");
      this.contactService.getAllContacts().subscribe(data=>{this.contacts=data;});
    }
  }

  
  



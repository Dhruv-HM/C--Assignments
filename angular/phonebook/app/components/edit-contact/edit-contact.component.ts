import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Contact } from 'src/app/models/contact';
import { ContatcService } from 'src/app/services/contatc-service.service';


@Component({
  selector: 'edit-contact',
  templateUrl: './edit-contact.component.html',
  styleUrls: ['./edit-contact.component.css']
})
export class EditContactComponent implements OnInit {

  editForm?:FormGroup;
  
  constructor(private activatedRoute:ActivatedRoute,private router:Router,private contactService:ContatcService) {
    
   }
   
   ngOnInit(): void {

    //access the route parameter
    this.activatedRoute.params.subscribe(paramsData=>{
        
    
      let id=paramsData['id'];

      

     this.contactService.getContactDetails(id)
     .subscribe((c: any) =>{
        let contact=c;

        this.editForm=new FormGroup(
          {
            id: new FormControl(contact.id),
          firstname:new FormControl(contact.firstname,Validators.required),
          lastname:new FormControl(contact.lastname,Validators.compose([Validators.required,Validators.minLength(5),Validators.maxLength(10)])),
          gender:new FormControl(contact.gender),
          dob:new FormControl(contact.dob),
          email:new FormControl(contact.email,Validators.email),
          phone:new FormControl(contact.phone),
          city:new FormControl(contact.city),
          state:new FormControl(contact.state),
          country:new FormControl(contact.country),
          picture:new FormControl(contact.picture),
          })
     })}
     )};
      
   
  saveContact(contact:Contact){
    this.contactService.updateContact(contact).subscribe(res=>{this.router.navigate(["/contact-list"]);});

    //navigate to contact list after hitting the save button
    

  }

}
    

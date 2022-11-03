import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/models/contact';
import { ContatcService } from 'src/app/services/contatc-service.service';

@Component({
  selector: 'contact-tem',
  templateUrl: './contact-tem.component.html',
  styleUrls: ['./contact-tem.component.css']
})
export class ContactTemComponent implements OnInit {
  contacts:Contact[]=[];
  @Input()
  contact?:Contact ;

  @Output()
  onReload:EventEmitter<void>= new EventEmitter<void>();
  constructor(private contactService:ContatcService,private router:Router) { }

  ngOnInit():void {
    
  }

  deleteContact(id:number){
     this.contactService.deleteContact(id).subscribe(data=>{
      this.onReload.emit();
      
    });}
  }


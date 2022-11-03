import { Injectable } from '@angular/core';
import { Contact } from '../models/contact';
import { HttpClient} from '@angular/common/http'

import 'rxjs-compat/add/operator/map';
import { Observable } from 'rxjs/internal/Observable';

const baseurl="http://localhost:3000";

@Injectable({
  providedIn: 'root'
})
export class ContatcService {
  contacts: Contact[] = [];
  constructor(private http:HttpClient) {


    // this.contacts.push(new Contact(1, "Chotta", "Bheem", "Male", "09-12-'88", "bheem.chotta@gmail.com", "123675", "Dholakpur", "Bihar", "India", "./assets/images/1.jpg"));
    // this.contacts.push(new Contact(2, "Chutki", "Chutki", "Female", "09-12-'88", "Chutki@gmail.com", "123675", "Dholakpur", "Bihar", "India", "./assets/images/2.jpg"));
    // this.contacts.push(new Contact(3, "Raju", "Mighty", "Male", "09-13-'88", "Chutki@gmail.com", "123675", "Dholakpur", "Bihar", "India", "./assets/images/3.jpg"));
    // this.contacts.push(new Contact(4, "Jaggu", "Bandhar", "Monkey", "03-12-'88", "Chutki@gmail.com", "123675", "Dholakpur", "Bihar", "India", "./assets/images/4.jpg"));
    // this.contacts.push(new Contact(5, "Khalia", "fat", "Male", "09-12-'88", "Chutki@gmail.com", "123675", "Dholakpur", "Bihar", "India", "./assets/images/5.jpg"));
  }
  ngOnInut(): void { }
  getAllContacts(): Observable<Contact[]> {
  return this.http.get<Contact[]>(baseurl);
  }

  addNewContact(contact: Contact):Observable<Contact> {
    return this.http.post<Contact>(baseurl,contact);
  }

  getContactDetails(id: number): Observable<Contact> {
    //let c: Contact = new Contact(0, "", "", "", "", "", "", "", "", "", "");
    // for (let index = 0; index < this.contacts.length; index++) {

    //   if (id == this.contacts[index].id) {
    //     c = this.contacts[index];
    //     return c;
    //   }

    // }
    //  return c;

    return this.http.get<Contact>(baseurl+"/"+id);
  }

  updateContact(contact: Contact) {
    // for (let index = 0; index < this.contacts.length; index++) {
    //   if (contact.id == this.contacts[index].id) {
    //     this.contacts[index] = contact;
    //   }
    return this.http.put<Contact>(baseurl+"/"+contact.id,contact);
    }

    deleteContact(id:number):Observable<Contact> {
    // for (let index = 0; index < this.contacts.length; index++) {
    //   if (contact.id == this.contacts[index].id) {
    //     this.contacts.splice(index, 1);
    //     break;
    //   } 
    // }
    return this.http.delete<Contact>(baseurl+"/"+id);
  }

}





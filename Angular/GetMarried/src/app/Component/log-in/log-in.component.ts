import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MustMatch } from '../../models/MustMuchPass';
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  hide=false;
  pass1 = "";
  pass2 = "";

  myGroup = new FormGroup({
    email :new FormControl('', [Validators.required, Validators.email]),
    emaillogin:new FormControl('', [Validators.required, Validators.email])
 });
 

  getErrorMessage() {
    return this.myGroup.get('email')?.hasError('required') ? 'הכנס ערך' :
    this.myGroup.get('email')?.hasError('email') ? 'לא תקין' :  '';
  }

  getErrorMessageLogin() {
    return this.myGroup.get('emaillogin')?.hasError('required') ? 'הכנס ערך' :
    this.myGroup.get('emaillogin')?.hasError('email') ? 'לא תקין' :'';
  }

  
  constructor(private formBuilder: FormBuilder) { }
  // add(customer: Customers) {
  //   this.serv.PostCustomers(customer);
  // }
  ngOnInit(): void {
  }

}

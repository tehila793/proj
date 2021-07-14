import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{HttpClientModule}from '@angular/common/http'
import { AppComponent } from './app.component';
import { CategoryComponent } from './Component/category/category.component';
import { HallsComponent } from './Component/halls/halls.component';
import { CustomersComponent } from './Component/customers/customers.component';
import { AddressComponent } from './Component/address/address.component';
import { AreaComponent } from './Component/area/area.component';
import { OpinionComponent } from './Component/opinion/opinion.component';
import { ProductsToCustomersComponent } from './Component/products-to-customers/products-to-customers.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import{MatInputModule}from '@angular/material/input';
import { SuppliersComponent } from './Component/suppliers/suppliers.component';
import { LogInComponent } from './Component/log-in/log-in.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { MatSliderModule } from '@angular/material/slider';
import { NavBarComponent } from './Component/nav-bar/nav-bar.component';
import {MatButtonModule} from '@angular/material/button';
import { RouterModule,Routes } from '@angular/router';
import { Pathes } from './models/pathes';
import { MainComponent } from './Component/main/main.component';


@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    HallsComponent,
    CustomersComponent,
    AddressComponent,
    AreaComponent,
    OpinionComponent,
    ProductsToCustomersComponent,
    //ServiceComponent,
    SuppliersComponent,
    LogInComponent,
    NavBarComponent,
    MainComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,MatFormFieldModule,
    BrowserAnimationsModule,
    FormsModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatSliderModule,
    RouterModule.forRoot(Pathes),
    
  ],
  providers: [],
  bootstrap: [AppComponent] ,
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA,
  ],
})
export class AppModule { }

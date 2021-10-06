import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './NavBar/NavBar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FooterComponent } from './Footer/Footer.component';
import { PizzaComponent } from './Pizza/Pizza.component';
import { HomeComponent } from './Home/Home.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ComprasComponent } from './Compras/Compras.component';

@NgModule({
  declarations: [							
    AppComponent,
      NavBarComponent,
      FooterComponent,
      PizzaComponent,
      HomeComponent,
      ComprasComponent
   ],
  imports: [
    ReactiveFormsModule,
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ModalModule.forRoot(),
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

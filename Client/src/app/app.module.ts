import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './SharePage/footer/footer.component';
import { NavbarComponent } from './SharePage/navbar/navbar.component';
import { FrontPageComponent } from './Pages/front-page/front-page.component';
import { AboutUsComponent } from './Pages/about-us/about-us.component';
import { CommingSoonComponent } from './Pages/comming-soon/comming-soon.component';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { RegisterPageComponent } from './Pages/register-page/register-page.component';




@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    NavbarComponent,
    FrontPageComponent,
    AboutUsComponent,
    CommingSoonComponent,
    LoginPageComponent,
    RegisterPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

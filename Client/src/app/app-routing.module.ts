import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommingSoonComponent } from './Pages/comming-soon/comming-soon.component';
import { AboutUsComponent } from './Pages/about-us/about-us.component';
import { FrontPageComponent } from './Pages/front-page/front-page.component';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { RegisterPageComponent } from './Pages/register-page/register-page.component';

const routes: Routes = [
  { path: '', component:FrontPageComponent},
  { path: 'aboutUs', component:AboutUsComponent},
  { path: 'commingSoon', component:CommingSoonComponent},
  { path: 'login', component:LoginPageComponent},
  { path: 'regristrer', component:RegisterPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

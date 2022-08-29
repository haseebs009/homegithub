import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserpageComponent } from './userpage/userpage.component';
import { TermsComponent } from './terms/terms.component';
const routes: Routes = [

  { path: 'Userpage', component: UserpageComponent },
  { path: 'Terms&Conditions', component: TermsComponent },
  {path: '**', component: UserpageComponent} 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { DropDownListModule } from '@syncfusion/ej2-angular-dropdowns';
import { ButtonModule } from '@syncfusion/ej2-angular-buttons';
import { ReviewFormComponent } from './review-form/review-form.component';
import { Route, RouteReuseStrategy, RouterModule } from '@angular/router';
import { CreateFormComponent } from './create-form/create-form.component';
import { ResultFormComponent } from './result-form/result-form.component';
import { CustomReuseStrategyService } from './custom-reuse-strategy.service';

const route: Route[] = [
  {
    path: '',
    redirectTo: 'create',
    pathMatch: 'full'
  },
  {
    path: 'create',
    component: CreateFormComponent,
    data: { shouldReuse: true }
  },
  
  { path: 'review',
  component: ReviewFormComponent},
  {
    path: 'result',
    component: ResultFormComponent,
  }
]
@NgModule({
  declarations: [
    AppComponent,
    ReviewFormComponent,
    CreateFormComponent,
    ResultFormComponent,
    
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,DropDownListModule,ButtonModule,
    RouterModule.forRoot(route)
  ],
  providers: [{
    provide: RouteReuseStrategy,
    useClass: CustomReuseStrategyService
   }],
  bootstrap: [AppComponent]
})
export class AppModule { }

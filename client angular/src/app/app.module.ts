import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllRecipeComponent } from './all-recipe/all-recipe.component';
import { SmallRecipeComponent } from './small-recipe/small-recipe.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddComponent } from './add/add.component';
import { EnterComponent } from './enter/enter.component';
import { LoginComponent } from './login/login.component';
import {MatSelectModule} from '@angular/material/select';
import {MatSliderModule} from '@angular/material/slider';
import { FullrComponent } from './fullr/fullr.component';
import { TimePipe } from './time.pipe';
import {MatTabsModule} from '@angular/material/tabs';
import { AddLayerComponent } from './add-layer/add-layer.component';
import {MatIconModule} from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FilterPipe } from './filter.pipe';
import {MatCardModule} from '@angular/material/card';
import { IconPipe } from './icon.pipe';
import {MatButtonModule} from '@angular/material/button';
import { IconcPipe } from './iconc.pipe';

@NgModule({
  declarations: [
    AppComponent,
    AllRecipeComponent,
    SmallRecipeComponent,
    AddComponent,
    EnterComponent,
    LoginComponent,
    FullrComponent,
    TimePipe,
    AddLayerComponent,
    FilterPipe,
    IconPipe,
    IconcPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    FormsModule,MatSelectModule,MatSliderModule,MatTabsModule,
    MatIconModule,MatButtonModule,
    MatFormFieldModule,
    MatInputModule,MatCardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

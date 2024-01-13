import { Routes } from '@angular/router';
import { MainpageComponent } from './mainpage/mainpage.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { MyAchievementsComponent } from './my-achievements/my-achievements.component';
import { ContactMeComponent } from './contact-me/contact-me.component';

export const routes: Routes = [
    {//for default path
        path: '',
        redirectTo: '/mainpage', //homapage landing
        pathMatch: 'full'
    }, {
        path: 'mainpage',
        component: MainpageComponent
    }, {
        path: 'header',
        component: HeaderComponent
    }
    , {
        path: 'footer',
        component: FooterComponent
    }
    , {
        path: 'achievements',
        component: MyAchievementsComponent
    }
    , {
        path: 'contact',
        component: ContactMeComponent
    }
];

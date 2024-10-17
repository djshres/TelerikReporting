import { Component, ViewChild } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ReportingAngularViewerComponent, ReportingAngularViewerModule } from '@progress/telerik-angular-native-report-viewer'
import { DocumentInfo } from '@progress/telerik-common-report-viewer'

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ReportingAngularViewerModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Native Angular Report Viewer Demo';

  @ViewChild('viewer') public viewer!: ReportingAngularViewerComponent;

  reportLoadComplete(e: DocumentInfo) {
    console.log("The document information such as the page count, where it has document map, etc. will ve sent via the e object.", e);
    console.log("This event will be emitted after the rendering of a report ends.");
};
}

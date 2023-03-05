import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IErrorModel } from "../models/error.model";

@Injectable()
export class ServerErrorInterceptor implements HttpInterceptor {
  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    return next.handle(request)
      .pipe(
        catchError((httpErrorResponse: HttpErrorResponse) => {
          if (httpErrorResponse.status !== 0) {
            const errorModel = httpErrorResponse.error as IErrorModel;

            // as a service
            alert(JSON.stringify({"error model": errorModel}, null, 4));
          }

          return throwError(() => httpErrorResponse);
        }),
      );
  }
}

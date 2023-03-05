import { IServerError } from "../activity-types/server-error";

export interface IServerErrorModel {
  errorStack: IServerError[],
}

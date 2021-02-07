import * as React from 'react';
import * as ReactDOM from 'react-dom';
import * as ReactDOMServer from 'react-dom/server';
import {ProjectList} from "./ProjectList";

const Components: any = {
    "ProjectList": ProjectList
};

// register components as global required by ReactJS.NET
for (const component in Components) {
    globalThis[component] = Components[component];
}

globalThis.React = React;
globalThis.ReactDOM = ReactDOM;
globalThis.ReactDOMServer = ReactDOMServer;


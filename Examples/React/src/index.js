import React from 'react';
import './index.css';
import { ReportViewer } from './reportViewer';
import { createRoot } from 'react-dom/client';

const container = document.getElementById('root');
const root = createRoot(container);
root.render(<ReportViewer />);

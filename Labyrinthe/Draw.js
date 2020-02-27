Laby.prototype.Draw=function(ctx,dx,dy,w) {
  var e,m,x,y,nc=this.Nc,X=nc*dx,Y=this.Nl*dy,sud=this.Sud,est=this.Est;

  ctx.strokeRect(0,0,X,Y);
  for (y=dy,e=0; y<Y; y+=dy) { // horizontal walls optimized
    for (x=0,m=0; x<X; x+=dx,e++)
      if (m!=sud[e]) {if (m=1-m) ctx.moveTo(x-w,y); else ctx.lineTo(x+w,y);}
    if (m) ctx.lineTo(x,y);
    ctx.stroke();
  }
  for (x=dx,l=0; x<X; x+=dx,l++) { // vertical walls optimized
    for (y=0,e=l,m=0; y<Y; y+=dy,e+=nc)
      if (m!=est[e]) {if (m=1-m) ctx.moveTo(x,y-w); else ctx.lineTo(x,y+w);}
    if (m) ctx.lineTo(x,y);
    ctx.stroke();
  }
} // by William VOIROL, Switzerland, Dec 2016
<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">


  <xsl:template match="/">
  <html>
  <head>
    <title>Pociones generadas</title>  
  </head>
  <body>
  <table>
  
    <xsl:apply-templates />
    </table>
    </body>  
  </html>
  </xsl:template>
  
  <xsl:template match="pociones/pocion">
  <table border="1" width="80%">
  <tr>
    <td bgcolor="#8f9cda">Tipo</td>
    <td bgcolor="#8f9cda" colspan="2">Poder</td>
  </tr>
  <tr>
    <td><xsl:value-of select="tipo"/></td>
    <td colspan="2"><xsl:value-of select="poder"/></td>
  </tr>
  <tr>
    <td bgcolor="#8f9cda">Efecto primario</td>
    <td bgcolor="#8f9cda" colspan="2">Efecto secundario</td>
  </tr>
  <tr>
    <td><xsl:value-of select="efecto1"/></td>
    <td colspan="2"><xsl:value-of select="efecto2"/></td>
  </tr>
  <tr>
    <td bgcolor="#8f9cda">Contenedor</td>
    <td bgcolor="#8f9cda">Color</td>
    <td bgcolor="#8f9cda">Detalles</td>
  </tr>
  <tr>
    <td><xsl:value-of select="contenedor"/></td>
    <td><xsl:value-of select="color"/></td>
    <td><xsl:value-of select="detalles"/></td>
  </tr>
   <tr>
    <td bgcolor="#8f9cda">Textura</td>
    <td bgcolor="#8f9cda">Olor</td>
    <td bgcolor="#8f9cda">Sabor</td>
  </tr>
  <tr>
    <td><xsl:value-of select="textura"/></td>
    <td><xsl:value-of select="olor"/></td>
    <td><xsl:value-of select="sabor"/></td>
  </tr>
  <tr>
    <td bgcolor="#8f9cda" colspan="3">Etiqueta</td>
  </tr>
  <tr>
    <td colspan="3"><xsl:value-of select="etiqueta"/></td>
  </tr>
</table>
<br/><br/>
  </xsl:template>
  
</xsl:stylesheet>

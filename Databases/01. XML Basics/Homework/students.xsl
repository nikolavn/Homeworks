<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>Students</h2>
        <table>
          <thead>
            <tr>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Gender</th>
              <th>Bith Date</th>
              <th>Phone</th>
              <th>E-mail</th>
              <th>Course</th>
              <th>Specialty</th>
              <th>Faculty Nr.</th>
            </tr>
          </thead>
          <tbody>
            <xsl:for-each select="/students/student">
              <tr>
                <td>
                  <xsl:value-of select="firstName"/>
                </td>
                <td>
                  <xsl:value-of select="lastName"/>
                </td>
              </tr>
            </xsl:for-each>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

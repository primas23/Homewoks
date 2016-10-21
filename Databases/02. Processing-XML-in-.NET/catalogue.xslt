<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes"/>
  <xsl:template match="/">
    <html>
      <body>
        <div id="table">
          <div id="th-group">
            <div class="cell">Title</div>
            <div class="cell">Artist</div>
            <div class="cell">Year</div>
            <div class="cell">Producer</div>
            <div class="cell">price</div>
            <div class="cell">Songs</div>
          </div>
          <div id="tbody">
            <xsl:for-each select="catalogue/album">
              <div class="row">
                <div class="cell">
                  <xsl:value-of select="name" />
                </div>
                <div class="cell">
                  <xsl:value-of select="artist" />
                </div>
                <div class="cell">
                  <xsl:value-of select="year" />
                </div>
                <div class="cell">
                  <xsl:value-of select="producer" />
                </div>
                <div class="cell">
                  <xsl:value-of select="price" />
                </div>
                <div class="cell">
                  <xsl:for-each select="songs/song">
                    <div class="inner-cell">
                      <strong>Title: 
                        <xsl:value-of select="title" />
                        <br />
                      </strong>
                      duration: <xsl:value-of select="duration"/><br />
                    </div>
                  </xsl:for-each>
                </div>
              </div>
            </xsl:for-each>
          </div>
        </div>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>